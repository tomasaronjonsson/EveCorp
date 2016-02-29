(function () {
	//create the controller
	function mapController($scope, $http,$timeout) {

		$scope.mapUpdateTimeout = 1000;

		//ná í gögnin fyrir kortið og setja svo sjálfvirkt update í gang
		$scope.updateSolarsystems = function() {
			$http.get("/Umbraco/Api/Map/GetSolarsystems")
                     .then(function (response) {
                     	$scope.solarsystems = response.data;
                     });

			$timeout(function () { $scope.updateSolarsystems(); }, $scope.mapUpdateTimeout);

		}

		$scope.updateSolarsystems();



	};

	//create the app
	var myApp = angular.module('eveMap', []);


	//register the controller
	myApp.controller('mapController', mapController);



})();