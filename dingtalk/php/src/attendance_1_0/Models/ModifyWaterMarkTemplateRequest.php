<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ModifyWaterMarkTemplateRequest extends Model
{
    /**
     * @description 模板的表单Code。
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 模板的预览图片。
     *
     * @var string
     */
    public $icon;

    /**
     * @description 模板的布局ID。
     *
     * @var string
     */
    public $layoutDesignId;

    /**
     * @description 模板的内容。
     *
     * @var string
     */
    public $schemaContent;

    /**
     * @description 模板的标题。
     *
     * @var string
     */
    public $title;

    /**
     * @description 模板的水印ID。
     *
     * @var string
     */
    public $waterMarkId;

    /**
     * @description 群会话ID。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 用户的userid。
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
