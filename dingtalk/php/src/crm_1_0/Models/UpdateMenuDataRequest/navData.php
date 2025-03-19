<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMenuDataRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMenuDataRequest\navData\navExtInfo;
use AlibabaCloud\Tea\Model;

class navData extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $displayStatus;

    /**
     * @example icon-biaodan_baogao
     *
     * @var string
     */
    public $icon;

    /**
     * @example #CCEEFF
     *
     * @var string
     */
    public $iconBgColor;

    /**
     * @example #007FFF
     *
     * @var string
     */
    public $iconColor;

    /**
     * @example same_page
     *
     * @var string
     */
    public $integrationProtocol;

    /**
     * @description This parameter is required.
     *
     * @example 库存账单
     *
     * @var string
     */
    public $mobileNavName;

    /**
     * @example https://tj-ali-crm-test.tangees.com/tungee/crm/mobile/?corpid=dinge18b222ec5637b04ffe93478753d9884#/form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?库存流水&psi_stock_flow&fromPage=home
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @description This parameter is required.
     *
     * @example lowcode_customize_form
     *
     * @var string
     */
    public $navCode;

    /**
     * @var navExtInfo
     */
    public $navExtInfo;

    /**
     * @description This parameter is required.
     *
     * @example lowcode_customize_form:PROC-0279E824-ED47-4E75-86F2-11B665F3704D
     *
     * @var string
     */
    public $navId;

    /**
     * @description This parameter is required.
     *
     * @example 库存流水
     *
     * @var string
     */
    public $navName;

    /**
     * @description This parameter is required.
     *
     * @example PUBLISHED
     *
     * @var string
     */
    public $navStatus;

    /**
     * @example item
     *
     * @var string
     */
    public $navType;

    /**
     * @example crm_product
     *
     * @var string
     */
    public $parentNavId;

    /**
     * @example tj
     *
     * @var string
     */
    public $provider;

    /**
     * @var int
     */
    public $sortNum;

    /**
     * @example /form/PROC-ECC13160-7AFF-4D5B-8E73-E5B98BB9A59B?bizType=psi_stock_flow&formName=库存流水
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'displayStatus' => 'displayStatus',
        'icon' => 'icon',
        'iconBgColor' => 'iconBgColor',
        'iconColor' => 'iconColor',
        'integrationProtocol' => 'integrationProtocol',
        'mobileNavName' => 'mobileNavName',
        'mobileUrl' => 'mobileUrl',
        'navCode' => 'navCode',
        'navExtInfo' => 'navExtInfo',
        'navId' => 'navId',
        'navName' => 'navName',
        'navStatus' => 'navStatus',
        'navType' => 'navType',
        'parentNavId' => 'parentNavId',
        'provider' => 'provider',
        'sortNum' => 'sortNum',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayStatus) {
            $res['displayStatus'] = $this->displayStatus;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->iconBgColor) {
            $res['iconBgColor'] = $this->iconBgColor;
        }
        if (null !== $this->iconColor) {
            $res['iconColor'] = $this->iconColor;
        }
        if (null !== $this->integrationProtocol) {
            $res['integrationProtocol'] = $this->integrationProtocol;
        }
        if (null !== $this->mobileNavName) {
            $res['mobileNavName'] = $this->mobileNavName;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->navCode) {
            $res['navCode'] = $this->navCode;
        }
        if (null !== $this->navExtInfo) {
            $res['navExtInfo'] = null !== $this->navExtInfo ? $this->navExtInfo->toMap() : null;
        }
        if (null !== $this->navId) {
            $res['navId'] = $this->navId;
        }
        if (null !== $this->navName) {
            $res['navName'] = $this->navName;
        }
        if (null !== $this->navStatus) {
            $res['navStatus'] = $this->navStatus;
        }
        if (null !== $this->navType) {
            $res['navType'] = $this->navType;
        }
        if (null !== $this->parentNavId) {
            $res['parentNavId'] = $this->parentNavId;
        }
        if (null !== $this->provider) {
            $res['provider'] = $this->provider;
        }
        if (null !== $this->sortNum) {
            $res['sortNum'] = $this->sortNum;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return navData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayStatus'])) {
            $model->displayStatus = $map['displayStatus'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['iconBgColor'])) {
            $model->iconBgColor = $map['iconBgColor'];
        }
        if (isset($map['iconColor'])) {
            $model->iconColor = $map['iconColor'];
        }
        if (isset($map['integrationProtocol'])) {
            $model->integrationProtocol = $map['integrationProtocol'];
        }
        if (isset($map['mobileNavName'])) {
            $model->mobileNavName = $map['mobileNavName'];
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['navCode'])) {
            $model->navCode = $map['navCode'];
        }
        if (isset($map['navExtInfo'])) {
            $model->navExtInfo = navExtInfo::fromMap($map['navExtInfo']);
        }
        if (isset($map['navId'])) {
            $model->navId = $map['navId'];
        }
        if (isset($map['navName'])) {
            $model->navName = $map['navName'];
        }
        if (isset($map['navStatus'])) {
            $model->navStatus = $map['navStatus'];
        }
        if (isset($map['navType'])) {
            $model->navType = $map['navType'];
        }
        if (isset($map['parentNavId'])) {
            $model->parentNavId = $map['parentNavId'];
        }
        if (isset($map['provider'])) {
            $model->provider = $map['provider'];
        }
        if (isset($map['sortNum'])) {
            $model->sortNum = $map['sortNum'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
