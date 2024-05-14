<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ModifyWaterMarkTemplateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example PROC-292988B1-5064-4A42-9389-A76B97xxxxx
     *
     * @var string
     */
    public $formCode;

    /**
     * @example https://xx.xx.png
     *
     * @var string
     */
    public $icon;

    /**
     * @example industry_dx_xx
     *
     * @var string
     */
    public $layoutDesignId;

    /**
     * @description This parameter is required.
     *
     * @example { \"items\":[ { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"enableModifyPlace\", \"id\":\"enableModifyPlace-undefined\", \"value\":\"true\" } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"modifyPlaceDistance\", \"id\":\"modifyPlaceDistance-undefined\", \"value\":200 } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"title\", \"id\":\"title-undefined\", \"value\":\"wofu1\" } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"titleBgColor\", \"id\":\"titleBgColor-undefined\", \"value\":\"#0089FF\" } } ] }
     *
     * @var string
     */
    public $schemaContent;

    /**
     * @example 标题
     *
     * @var string
     */
    public $title;

    /**
     * @example PROC-292988B1-5064-4A42-9389-A76B97xxxxx
     *
     * @var string
     */
    public $waterMarkId;

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
        'formCode'           => 'formCode',
        'icon'               => 'icon',
        'layoutDesignId'     => 'layoutDesignId',
        'schemaContent'      => 'schemaContent',
        'title'              => 'title',
        'waterMarkId'        => 'waterMarkId',
        'openConversationId' => 'openConversationId',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->layoutDesignId) {
            $res['layoutDesignId'] = $this->layoutDesignId;
        }
        if (null !== $this->schemaContent) {
            $res['schemaContent'] = $this->schemaContent;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->waterMarkId) {
            $res['waterMarkId'] = $this->waterMarkId;
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
     * @return ModifyWaterMarkTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['layoutDesignId'])) {
            $model->layoutDesignId = $map['layoutDesignId'];
        }
        if (isset($map['schemaContent'])) {
            $model->schemaContent = $map['schemaContent'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['waterMarkId'])) {
            $model->waterMarkId = $map['waterMarkId'];
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
