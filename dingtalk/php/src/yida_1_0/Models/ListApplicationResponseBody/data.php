<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example {"ODIN_TOPIC_ID":"2560649","APPPROVIDER":"vigo","NEEDAYALYSIS":"n","NAVTYPE":"top_side","SHOWICON":"n","REPORT_SUPPORT_META_3":"y","ALLOW_EXTERNAL_ADDRESS_BOOK":"y","REPORTVERSION":"V5","FORM_SCHEMA_VERSION":"V5","EXCEL_SOURCE":"LOCAL","DEVICETYPE":"web,mobile","ENABLE_CSRF_SWITCH":"y","NEW_ALLOW_EXTERNAL_ADDRESS_BOOK":"y","COLOUR":"blue","DINGTALK_CID":"LOCAL","APPMODE":"normal","NAVLAYOUT":"auto","SHOWNAV":"y","SHOWCRUMB":"y","SUPPORT_META_3":"y","SUPPORT_META_2":"y","SYSTEMLINK":"https://www.aliwork.com/APP_LDYQVBGT167NAON5KB1X/workbench","DATA_QUERY_VERSION":"V1","DB_SOURCE_TYPE":"TDDL_MYSQL","ISTODINGAPPCENTER":"n","REVERSION":"5.9.16","EDS_DB_INDEX":"24","NAVIGATION":"TODO,DONE,SUBMIT","APPTYPE":"single"}
     *
     * @var string
     */
    public $appConfig;

    /**
     * @example APP_XCE0EVXS6DYG3YDYC5RD
     *
     * @var string
     */
    public $appType;

    /**
     * @example 上线:ONLINE，下线:OFFLINE
     *
     * @var string
     */
    public $applicationStatus;

    /**
     * @example ding5d17e3add038d44535c2f4657eb6378e
     *
     * @var string
     */
    public $corpId;

    /**
     * @example ding12345
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @example 步凡创建的宜搭应用
     *
     * @var string
     */
    public $description;

    /**
     * @example appdiqiu%%#0089FF
     *
     * @var string
     */
    public $icon;

    /**
     * @example 已删除:y，未删除:n
     *
     * @var string
     */
    public $inexistence;

    /**
     * @example 测试应用
     *
     * @var string
     */
    public $name;

    /**
     * @example ding8eaadfkksj45343wksff334
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @var string
     */
    public $systemToken;
    protected $_name = [
        'appConfig'         => 'appConfig',
        'appType'           => 'appType',
        'applicationStatus' => 'applicationStatus',
        'corpId'            => 'corpId',
        'creatorUserId'     => 'creatorUserId',
        'description'       => 'description',
        'icon'              => 'icon',
        'inexistence'       => 'inexistence',
        'name'              => 'name',
        'subCorpId'         => 'subCorpId',
        'systemToken'       => 'systemToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appConfig) {
            $res['appConfig'] = $this->appConfig;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->applicationStatus) {
            $res['applicationStatus'] = $this->applicationStatus;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->inexistence) {
            $res['inexistence'] = $this->inexistence;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appConfig'])) {
            $model->appConfig = $map['appConfig'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['applicationStatus'])) {
            $model->applicationStatus = $map['applicationStatus'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['inexistence'])) {
            $model->inexistence = $map['inexistence'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }

        return $model;
    }
}
