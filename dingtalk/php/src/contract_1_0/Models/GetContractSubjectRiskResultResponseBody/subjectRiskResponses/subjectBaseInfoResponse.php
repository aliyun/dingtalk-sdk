<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody\subjectRiskResponses;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody\subjectRiskResponses\subjectBaseInfoResponse\industryAll;
use AlibabaCloud\Tea\Model;

class subjectBaseInfoResponse extends Model
{
    /**
     * @var string
     */
    public $aboveScale;

    /**
     * @var string
     */
    public $actualCapital;

    /**
     * @var string
     */
    public $actualCapitalCurrency;

    /**
     * @var string
     */
    public $alias;

    /**
     * @var int
     */
    public $approvedTime;

    /**
     * @var string
     */
    public $base;

    /**
     * @var string
     */
    public $benNumber;

    /**
     * @var string
     */
    public $bondName;

    /**
     * @var string
     */
    public $bondNum;

    /**
     * @var string
     */
    public $bondType;

    /**
     * @var string
     */
    public $businessScope;

    /**
     * @var int
     */
    public $cancelDate;

    /**
     * @var string
     */
    public $cancelReason;

    /**
     * @var string
     */
    public $city;

    /**
     * @var string
     */
    public $companyOrgType;

    /**
     * @var string
     */
    public $creditCode;

    /**
     * @var string
     */
    public $district;

    /**
     * @var string
     */
    public $districtCode;

    /**
     * @var string
     */
    public $economicFunctionZone1;

    /**
     * @var string
     */
    public $economicFunctionZone2;

    /**
     * @var string
     */
    public $email;

    /**
     * @var string
     */
    public $emailList;

    /**
     * @var int
     */
    public $establishTime;

    /**
     * @var int
     */
    public $fromTime;

    /**
     * @var string[]
     */
    public $historyNameList;

    /**
     * @var string
     */
    public $historyNames;

    /**
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $industry;

    /**
     * @var industryAll
     */
    public $industryAll;

    /**
     * @var int
     */
    public $isMicroEnt;

    /**
     * @var string
     */
    public $legalPersonName;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $numberSource;

    /**
     * @var string
     */
    public $numberType;

    /**
     * @var string
     */
    public $orgNumber;

    /**
     * @var int
     */
    public $percentileScore;

    /**
     * @var string
     */
    public $phoneNumber;

    /**
     * @var string
     */
    public $property3;

    /**
     * @var string
     */
    public $regCapital;

    /**
     * @var string
     */
    public $regCapitalCurrency;

    /**
     * @var string
     */
    public $regInstitute;

    /**
     * @var string
     */
    public $regLocation;

    /**
     * @var string
     */
    public $regLocationHalfWidth;

    /**
     * @var string
     */
    public $regNumber;

    /**
     * @var string
     */
    public $regStatus;

    /**
     * @var int
     */
    public $revokeDate;

    /**
     * @var string
     */
    public $revokeReason;

    /**
     * @var int
     */
    public $socialStaffNum;

    /**
     * @var string
     */
    public $staffNumRange;

    /**
     * @var string
     */
    public $tags;

    /**
     * @var string
     */
    public $taxNumber;

    /**
     * @var int
     */
    public $toTime;

    /**
     * @var int
     */
    public $type;

    /**
     * @var int
     */
    public $updateTimes;

    /**
     * @var string
     */
    public $usedBondName;

    /**
     * @var string
     */
    public $websiteList;
    protected $_name = [
        'aboveScale' => 'aboveScale',
        'actualCapital' => 'actualCapital',
        'actualCapitalCurrency' => 'actualCapitalCurrency',
        'alias' => 'alias',
        'approvedTime' => 'approvedTime',
        'base' => 'base',
        'benNumber' => 'benNumber',
        'bondName' => 'bondName',
        'bondNum' => 'bondNum',
        'bondType' => 'bondType',
        'businessScope' => 'businessScope',
        'cancelDate' => 'cancelDate',
        'cancelReason' => 'cancelReason',
        'city' => 'city',
        'companyOrgType' => 'companyOrgType',
        'creditCode' => 'creditCode',
        'district' => 'district',
        'districtCode' => 'districtCode',
        'economicFunctionZone1' => 'economicFunctionZone1',
        'economicFunctionZone2' => 'economicFunctionZone2',
        'email' => 'email',
        'emailList' => 'emailList',
        'establishTime' => 'establishTime',
        'fromTime' => 'fromTime',
        'historyNameList' => 'historyNameList',
        'historyNames' => 'historyNames',
        'id' => 'id',
        'industry' => 'industry',
        'industryAll' => 'industryAll',
        'isMicroEnt' => 'isMicroEnt',
        'legalPersonName' => 'legalPersonName',
        'name' => 'name',
        'numberSource' => 'numberSource',
        'numberType' => 'numberType',
        'orgNumber' => 'orgNumber',
        'percentileScore' => 'percentileScore',
        'phoneNumber' => 'phoneNumber',
        'property3' => 'property3',
        'regCapital' => 'regCapital',
        'regCapitalCurrency' => 'regCapitalCurrency',
        'regInstitute' => 'regInstitute',
        'regLocation' => 'regLocation',
        'regLocationHalfWidth' => 'regLocationHalfWidth',
        'regNumber' => 'regNumber',
        'regStatus' => 'regStatus',
        'revokeDate' => 'revokeDate',
        'revokeReason' => 'revokeReason',
        'socialStaffNum' => 'socialStaffNum',
        'staffNumRange' => 'staffNumRange',
        'tags' => 'tags',
        'taxNumber' => 'taxNumber',
        'toTime' => 'toTime',
        'type' => 'type',
        'updateTimes' => 'updateTimes',
        'usedBondName' => 'usedBondName',
        'websiteList' => 'websiteList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aboveScale) {
            $res['aboveScale'] = $this->aboveScale;
        }
        if (null !== $this->actualCapital) {
            $res['actualCapital'] = $this->actualCapital;
        }
        if (null !== $this->actualCapitalCurrency) {
            $res['actualCapitalCurrency'] = $this->actualCapitalCurrency;
        }
        if (null !== $this->alias) {
            $res['alias'] = $this->alias;
        }
        if (null !== $this->approvedTime) {
            $res['approvedTime'] = $this->approvedTime;
        }
        if (null !== $this->base) {
            $res['base'] = $this->base;
        }
        if (null !== $this->benNumber) {
            $res['benNumber'] = $this->benNumber;
        }
        if (null !== $this->bondName) {
            $res['bondName'] = $this->bondName;
        }
        if (null !== $this->bondNum) {
            $res['bondNum'] = $this->bondNum;
        }
        if (null !== $this->bondType) {
            $res['bondType'] = $this->bondType;
        }
        if (null !== $this->businessScope) {
            $res['businessScope'] = $this->businessScope;
        }
        if (null !== $this->cancelDate) {
            $res['cancelDate'] = $this->cancelDate;
        }
        if (null !== $this->cancelReason) {
            $res['cancelReason'] = $this->cancelReason;
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->companyOrgType) {
            $res['companyOrgType'] = $this->companyOrgType;
        }
        if (null !== $this->creditCode) {
            $res['creditCode'] = $this->creditCode;
        }
        if (null !== $this->district) {
            $res['district'] = $this->district;
        }
        if (null !== $this->districtCode) {
            $res['districtCode'] = $this->districtCode;
        }
        if (null !== $this->economicFunctionZone1) {
            $res['economicFunctionZone1'] = $this->economicFunctionZone1;
        }
        if (null !== $this->economicFunctionZone2) {
            $res['economicFunctionZone2'] = $this->economicFunctionZone2;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->emailList) {
            $res['emailList'] = $this->emailList;
        }
        if (null !== $this->establishTime) {
            $res['establishTime'] = $this->establishTime;
        }
        if (null !== $this->fromTime) {
            $res['fromTime'] = $this->fromTime;
        }
        if (null !== $this->historyNameList) {
            $res['historyNameList'] = $this->historyNameList;
        }
        if (null !== $this->historyNames) {
            $res['historyNames'] = $this->historyNames;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }
        if (null !== $this->industryAll) {
            $res['industryAll'] = null !== $this->industryAll ? $this->industryAll->toMap() : null;
        }
        if (null !== $this->isMicroEnt) {
            $res['isMicroEnt'] = $this->isMicroEnt;
        }
        if (null !== $this->legalPersonName) {
            $res['legalPersonName'] = $this->legalPersonName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->numberSource) {
            $res['numberSource'] = $this->numberSource;
        }
        if (null !== $this->numberType) {
            $res['numberType'] = $this->numberType;
        }
        if (null !== $this->orgNumber) {
            $res['orgNumber'] = $this->orgNumber;
        }
        if (null !== $this->percentileScore) {
            $res['percentileScore'] = $this->percentileScore;
        }
        if (null !== $this->phoneNumber) {
            $res['phoneNumber'] = $this->phoneNumber;
        }
        if (null !== $this->property3) {
            $res['property3'] = $this->property3;
        }
        if (null !== $this->regCapital) {
            $res['regCapital'] = $this->regCapital;
        }
        if (null !== $this->regCapitalCurrency) {
            $res['regCapitalCurrency'] = $this->regCapitalCurrency;
        }
        if (null !== $this->regInstitute) {
            $res['regInstitute'] = $this->regInstitute;
        }
        if (null !== $this->regLocation) {
            $res['regLocation'] = $this->regLocation;
        }
        if (null !== $this->regLocationHalfWidth) {
            $res['regLocationHalfWidth'] = $this->regLocationHalfWidth;
        }
        if (null !== $this->regNumber) {
            $res['regNumber'] = $this->regNumber;
        }
        if (null !== $this->regStatus) {
            $res['regStatus'] = $this->regStatus;
        }
        if (null !== $this->revokeDate) {
            $res['revokeDate'] = $this->revokeDate;
        }
        if (null !== $this->revokeReason) {
            $res['revokeReason'] = $this->revokeReason;
        }
        if (null !== $this->socialStaffNum) {
            $res['socialStaffNum'] = $this->socialStaffNum;
        }
        if (null !== $this->staffNumRange) {
            $res['staffNumRange'] = $this->staffNumRange;
        }
        if (null !== $this->tags) {
            $res['tags'] = $this->tags;
        }
        if (null !== $this->taxNumber) {
            $res['taxNumber'] = $this->taxNumber;
        }
        if (null !== $this->toTime) {
            $res['toTime'] = $this->toTime;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->updateTimes) {
            $res['updateTimes'] = $this->updateTimes;
        }
        if (null !== $this->usedBondName) {
            $res['usedBondName'] = $this->usedBondName;
        }
        if (null !== $this->websiteList) {
            $res['websiteList'] = $this->websiteList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subjectBaseInfoResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aboveScale'])) {
            $model->aboveScale = $map['aboveScale'];
        }
        if (isset($map['actualCapital'])) {
            $model->actualCapital = $map['actualCapital'];
        }
        if (isset($map['actualCapitalCurrency'])) {
            $model->actualCapitalCurrency = $map['actualCapitalCurrency'];
        }
        if (isset($map['alias'])) {
            $model->alias = $map['alias'];
        }
        if (isset($map['approvedTime'])) {
            $model->approvedTime = $map['approvedTime'];
        }
        if (isset($map['base'])) {
            $model->base = $map['base'];
        }
        if (isset($map['benNumber'])) {
            $model->benNumber = $map['benNumber'];
        }
        if (isset($map['bondName'])) {
            $model->bondName = $map['bondName'];
        }
        if (isset($map['bondNum'])) {
            $model->bondNum = $map['bondNum'];
        }
        if (isset($map['bondType'])) {
            $model->bondType = $map['bondType'];
        }
        if (isset($map['businessScope'])) {
            $model->businessScope = $map['businessScope'];
        }
        if (isset($map['cancelDate'])) {
            $model->cancelDate = $map['cancelDate'];
        }
        if (isset($map['cancelReason'])) {
            $model->cancelReason = $map['cancelReason'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['companyOrgType'])) {
            $model->companyOrgType = $map['companyOrgType'];
        }
        if (isset($map['creditCode'])) {
            $model->creditCode = $map['creditCode'];
        }
        if (isset($map['district'])) {
            $model->district = $map['district'];
        }
        if (isset($map['districtCode'])) {
            $model->districtCode = $map['districtCode'];
        }
        if (isset($map['economicFunctionZone1'])) {
            $model->economicFunctionZone1 = $map['economicFunctionZone1'];
        }
        if (isset($map['economicFunctionZone2'])) {
            $model->economicFunctionZone2 = $map['economicFunctionZone2'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['emailList'])) {
            $model->emailList = $map['emailList'];
        }
        if (isset($map['establishTime'])) {
            $model->establishTime = $map['establishTime'];
        }
        if (isset($map['fromTime'])) {
            $model->fromTime = $map['fromTime'];
        }
        if (isset($map['historyNameList'])) {
            if (!empty($map['historyNameList'])) {
                $model->historyNameList = $map['historyNameList'];
            }
        }
        if (isset($map['historyNames'])) {
            $model->historyNames = $map['historyNames'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }
        if (isset($map['industryAll'])) {
            $model->industryAll = industryAll::fromMap($map['industryAll']);
        }
        if (isset($map['isMicroEnt'])) {
            $model->isMicroEnt = $map['isMicroEnt'];
        }
        if (isset($map['legalPersonName'])) {
            $model->legalPersonName = $map['legalPersonName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['numberSource'])) {
            $model->numberSource = $map['numberSource'];
        }
        if (isset($map['numberType'])) {
            $model->numberType = $map['numberType'];
        }
        if (isset($map['orgNumber'])) {
            $model->orgNumber = $map['orgNumber'];
        }
        if (isset($map['percentileScore'])) {
            $model->percentileScore = $map['percentileScore'];
        }
        if (isset($map['phoneNumber'])) {
            $model->phoneNumber = $map['phoneNumber'];
        }
        if (isset($map['property3'])) {
            $model->property3 = $map['property3'];
        }
        if (isset($map['regCapital'])) {
            $model->regCapital = $map['regCapital'];
        }
        if (isset($map['regCapitalCurrency'])) {
            $model->regCapitalCurrency = $map['regCapitalCurrency'];
        }
        if (isset($map['regInstitute'])) {
            $model->regInstitute = $map['regInstitute'];
        }
        if (isset($map['regLocation'])) {
            $model->regLocation = $map['regLocation'];
        }
        if (isset($map['regLocationHalfWidth'])) {
            $model->regLocationHalfWidth = $map['regLocationHalfWidth'];
        }
        if (isset($map['regNumber'])) {
            $model->regNumber = $map['regNumber'];
        }
        if (isset($map['regStatus'])) {
            $model->regStatus = $map['regStatus'];
        }
        if (isset($map['revokeDate'])) {
            $model->revokeDate = $map['revokeDate'];
        }
        if (isset($map['revokeReason'])) {
            $model->revokeReason = $map['revokeReason'];
        }
        if (isset($map['socialStaffNum'])) {
            $model->socialStaffNum = $map['socialStaffNum'];
        }
        if (isset($map['staffNumRange'])) {
            $model->staffNumRange = $map['staffNumRange'];
        }
        if (isset($map['tags'])) {
            $model->tags = $map['tags'];
        }
        if (isset($map['taxNumber'])) {
            $model->taxNumber = $map['taxNumber'];
        }
        if (isset($map['toTime'])) {
            $model->toTime = $map['toTime'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['updateTimes'])) {
            $model->updateTimes = $map['updateTimes'];
        }
        if (isset($map['usedBondName'])) {
            $model->usedBondName = $map['usedBondName'];
        }
        if (isset($map['websiteList'])) {
            $model->websiteList = $map['websiteList'];
        }

        return $model;
    }
}
