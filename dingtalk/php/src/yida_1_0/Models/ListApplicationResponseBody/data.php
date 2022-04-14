<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 宜搭应用配置
     *
     * @var string
     */
    public $appConfig;

    /**
     * @description 宜搭应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 应用状态
     *
     * @var string
     */
    public $applicationStatus;

    /**
     * @description 钉钉组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 创建者的userId
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 描述信息
     *
     * @var string
     */
    public $description;

    /**
     * @description 宜搭图标编码
     *
     * @var string
     */
    public $icon;

    /**
     * @description 是否被删除了
     *
     * @var string
     */
    public $inexistence;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 子组织的钉钉CorpId
     *
     * @var string
     */
    public $subCorpId;
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

        return $model;
    }
}
