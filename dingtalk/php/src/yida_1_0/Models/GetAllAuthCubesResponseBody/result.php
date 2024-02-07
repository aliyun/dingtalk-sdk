<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAllAuthCubesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAllAuthCubesResponseBody\result\cubeDataRanges;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAllAuthCubesResponseBody\result\userInformation;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $apappliedCount;

    /**
     * @var string
     */
    public $appCode;

    /**
     * @var string
     */
    public $appInstanceCode;

    /**
     * @var string
     */
    public $appStoreCode;

    /**
     * @var string
     */
    public $authMode;

    /**
     * @example all
     *
     * @var int
     */
    public $authorizationType;

    /**
     * @var string
     */
    public $businessProcessCode;

    /**
     * @var string
     */
    public $categoriesFirst;

    /**
     * @var string
     */
    public $categoriesSecond;

    /**
     * @example 2021-05-01
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @example ding12345
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @var string
     */
    public $cubeAuthType;

    /**
     * @var string
     */
    public $cubeCode;

    /**
     * @var string
     */
    public $cubeDataRange;

    /**
     * @var cubeDataRanges[]
     */
    public $cubeDataRanges;

    /**
     * @var string
     */
    public $cubeSource;

    /**
     * @var string
     */
    public $dataCacheTimeConfiguration;

    /**
     * @var string
     */
    public $dataflowCode;

    /**
     * @example 步凡创建的宜搭应用
     *
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $domainCode;

    /**
     * @var bool
     */
    public $enableCache;

    /**
     * @example 12345
     *
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $isNeedApplication;

    /**
     * @var string
     */
    public $isTrend;

    /**
     * @example 2021-05-01
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @example manager123
     *
     * @var string
     */
    public $modifier;

    /**
     * @example 测试应用
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $namespaceCode;

    /**
     * @var string
     */
    public $owner;

    /**
     * @var bool
     */
    public $sharedDataSet;

    /**
     * @var string
     */
    public $tenantCorpId;

    /**
     * @example i18n
     *
     * @var string
     */
    public $type;

    /**
     * @var userInformation
     */
    public $userInformation;
    protected $_name = [
        'apappliedCount'             => 'apappliedCount',
        'appCode'                    => 'appCode',
        'appInstanceCode'            => 'appInstanceCode',
        'appStoreCode'               => 'appStoreCode',
        'authMode'                   => 'authMode',
        'authorizationType'          => 'authorizationType',
        'businessProcessCode'        => 'businessProcessCode',
        'categoriesFirst'            => 'categoriesFirst',
        'categoriesSecond'           => 'categoriesSecond',
        'createTimeGMT'              => 'createTimeGMT',
        'creatorUserId'              => 'creatorUserId',
        'cubeAuthType'               => 'cubeAuthType',
        'cubeCode'                   => 'cubeCode',
        'cubeDataRange'              => 'cubeDataRange',
        'cubeDataRanges'             => 'cubeDataRanges',
        'cubeSource'                 => 'cubeSource',
        'dataCacheTimeConfiguration' => 'dataCacheTimeConfiguration',
        'dataflowCode'               => 'dataflowCode',
        'description'                => 'description',
        'domainCode'                 => 'domainCode',
        'enableCache'                => 'enableCache',
        'id'                         => 'id',
        'isNeedApplication'          => 'isNeedApplication',
        'isTrend'                    => 'isTrend',
        'modifiedTimeGMT'            => 'modifiedTimeGMT',
        'modifier'                   => 'modifier',
        'name'                       => 'name',
        'namespaceCode'              => 'namespaceCode',
        'owner'                      => 'owner',
        'sharedDataSet'              => 'sharedDataSet',
        'tenantCorpId'               => 'tenantCorpId',
        'type'                       => 'type',
        'userInformation'            => 'userInformation',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->apappliedCount) {
            $res['apappliedCount'] = $this->apappliedCount;
        }
        if (null !== $this->appCode) {
            $res['appCode'] = $this->appCode;
        }
        if (null !== $this->appInstanceCode) {
            $res['appInstanceCode'] = $this->appInstanceCode;
        }
        if (null !== $this->appStoreCode) {
            $res['appStoreCode'] = $this->appStoreCode;
        }
        if (null !== $this->authMode) {
            $res['authMode'] = $this->authMode;
        }
        if (null !== $this->authorizationType) {
            $res['authorizationType'] = $this->authorizationType;
        }
        if (null !== $this->businessProcessCode) {
            $res['businessProcessCode'] = $this->businessProcessCode;
        }
        if (null !== $this->categoriesFirst) {
            $res['categoriesFirst'] = $this->categoriesFirst;
        }
        if (null !== $this->categoriesSecond) {
            $res['categoriesSecond'] = $this->categoriesSecond;
        }
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->cubeAuthType) {
            $res['cubeAuthType'] = $this->cubeAuthType;
        }
        if (null !== $this->cubeCode) {
            $res['cubeCode'] = $this->cubeCode;
        }
        if (null !== $this->cubeDataRange) {
            $res['cubeDataRange'] = $this->cubeDataRange;
        }
        if (null !== $this->cubeDataRanges) {
            $res['cubeDataRanges'] = [];
            if (null !== $this->cubeDataRanges && \is_array($this->cubeDataRanges)) {
                $n = 0;
                foreach ($this->cubeDataRanges as $item) {
                    $res['cubeDataRanges'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->cubeSource) {
            $res['cubeSource'] = $this->cubeSource;
        }
        if (null !== $this->dataCacheTimeConfiguration) {
            $res['dataCacheTimeConfiguration'] = $this->dataCacheTimeConfiguration;
        }
        if (null !== $this->dataflowCode) {
            $res['dataflowCode'] = $this->dataflowCode;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->domainCode) {
            $res['domainCode'] = $this->domainCode;
        }
        if (null !== $this->enableCache) {
            $res['enableCache'] = $this->enableCache;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isNeedApplication) {
            $res['isNeedApplication'] = $this->isNeedApplication;
        }
        if (null !== $this->isTrend) {
            $res['isTrend'] = $this->isTrend;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = $this->modifier;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->namespaceCode) {
            $res['namespaceCode'] = $this->namespaceCode;
        }
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
        }
        if (null !== $this->sharedDataSet) {
            $res['sharedDataSet'] = $this->sharedDataSet;
        }
        if (null !== $this->tenantCorpId) {
            $res['tenantCorpId'] = $this->tenantCorpId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userInformation) {
            $res['userInformation'] = null !== $this->userInformation ? $this->userInformation->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apappliedCount'])) {
            $model->apappliedCount = $map['apappliedCount'];
        }
        if (isset($map['appCode'])) {
            $model->appCode = $map['appCode'];
        }
        if (isset($map['appInstanceCode'])) {
            $model->appInstanceCode = $map['appInstanceCode'];
        }
        if (isset($map['appStoreCode'])) {
            $model->appStoreCode = $map['appStoreCode'];
        }
        if (isset($map['authMode'])) {
            $model->authMode = $map['authMode'];
        }
        if (isset($map['authorizationType'])) {
            $model->authorizationType = $map['authorizationType'];
        }
        if (isset($map['businessProcessCode'])) {
            $model->businessProcessCode = $map['businessProcessCode'];
        }
        if (isset($map['categoriesFirst'])) {
            $model->categoriesFirst = $map['categoriesFirst'];
        }
        if (isset($map['categoriesSecond'])) {
            $model->categoriesSecond = $map['categoriesSecond'];
        }
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['cubeAuthType'])) {
            $model->cubeAuthType = $map['cubeAuthType'];
        }
        if (isset($map['cubeCode'])) {
            $model->cubeCode = $map['cubeCode'];
        }
        if (isset($map['cubeDataRange'])) {
            $model->cubeDataRange = $map['cubeDataRange'];
        }
        if (isset($map['cubeDataRanges'])) {
            if (!empty($map['cubeDataRanges'])) {
                $model->cubeDataRanges = [];
                $n                     = 0;
                foreach ($map['cubeDataRanges'] as $item) {
                    $model->cubeDataRanges[$n++] = null !== $item ? cubeDataRanges::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['cubeSource'])) {
            $model->cubeSource = $map['cubeSource'];
        }
        if (isset($map['dataCacheTimeConfiguration'])) {
            $model->dataCacheTimeConfiguration = $map['dataCacheTimeConfiguration'];
        }
        if (isset($map['dataflowCode'])) {
            $model->dataflowCode = $map['dataflowCode'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['domainCode'])) {
            $model->domainCode = $map['domainCode'];
        }
        if (isset($map['enableCache'])) {
            $model->enableCache = $map['enableCache'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isNeedApplication'])) {
            $model->isNeedApplication = $map['isNeedApplication'];
        }
        if (isset($map['isTrend'])) {
            $model->isTrend = $map['isTrend'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = $map['modifier'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['namespaceCode'])) {
            $model->namespaceCode = $map['namespaceCode'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['sharedDataSet'])) {
            $model->sharedDataSet = $map['sharedDataSet'];
        }
        if (isset($map['tenantCorpId'])) {
            $model->tenantCorpId = $map['tenantCorpId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userInformation'])) {
            $model->userInformation = userInformation::fromMap($map['userInformation']);
        }

        return $model;
    }
}
