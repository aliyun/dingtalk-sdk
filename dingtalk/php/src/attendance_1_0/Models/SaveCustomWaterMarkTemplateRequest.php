<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveCustomWaterMarkTemplateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example water_mark_checkin
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example https://xx.xx.png
     *
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @example industry_dx_xx
     *
     * @var string
     */
    public $layoutDesignId;

    /**
     * @description This parameter is required.
     *
     * @example water_mark_checkin_open
     *
     * @var string
     */
    public $sceneCode;

    /**
     * @description This parameter is required.
     *
     * @example { \"items\":[ { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"enableModifyPlace\", \"id\":\"enableModifyPlace-undefined\", \"value\":\"true\" } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"modifyPlaceDistance\", \"id\":\"modifyPlaceDistance-undefined\", \"value\":200 } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"title\", \"id\":\"title-undefined\", \"value\":\"wofu1\" } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"titleBgColor\", \"id\":\"titleBgColor-undefined\", \"value\":\"#0089FF\" } } ] }
     *
     * @var string
     */
    public $schemaContent;

    /**
     * @description This parameter is required.
     *
     * @example 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example 1234567
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example manage123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizCode'            => 'bizCode',
        'icon'               => 'icon',
        'layoutDesignId'     => 'layoutDesignId',
        'sceneCode'          => 'sceneCode',
        'schemaContent'      => 'schemaContent',
        'title'              => 'title',
        'openConversationId' => 'openConversationId',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->layoutDesignId) {
            $res['layoutDesignId'] = $this->layoutDesignId;
        }
        if (null !== $this->sceneCode) {
            $res['sceneCode'] = $this->sceneCode;
        }
        if (null !== $this->schemaContent) {
            $res['schemaContent'] = $this->schemaContent;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveCustomWaterMarkTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['layoutDesignId'])) {
            $model->layoutDesignId = $map['layoutDesignId'];
        }
        if (isset($map['sceneCode'])) {
            $model->sceneCode = $map['sceneCode'];
        }
        if (isset($map['schemaContent'])) {
            $model->schemaContent = $map['schemaContent'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
