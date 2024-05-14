<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteWaterMarkTemplateRequest extends Model
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
     * @example {     \"items\":[         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"enableModifyPlace\",                 \"id\":\"enableModifyPlace-undefined\",                 \"value\":\"true\"             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"modifyPlaceDistance\",                 \"id\":\"modifyPlaceDistance-undefined\",                 \"value\":200             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"title\",                 \"id\":\"title-undefined\",                 \"value\":\"wofu1\"             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"titleBgColor\",                 \"id\":\"titleBgColor-undefined\",                 \"value\":\"#0089FF\"             }         }     ] }
     *
     * @var string
     */
    public $formContent;

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
     * @var bool
     */
    public $systemTemplate;

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
        'formContent'        => 'formContent',
        'openConversationId' => 'openConversationId',
        'systemTemplate'     => 'systemTemplate',
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
        if (null !== $this->formContent) {
            $res['formContent'] = $this->formContent;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->systemTemplate) {
            $res['systemTemplate'] = $this->systemTemplate;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteWaterMarkTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['formContent'])) {
            $model->formContent = $map['formContent'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['systemTemplate'])) {
            $model->systemTemplate = $map['systemTemplate'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
