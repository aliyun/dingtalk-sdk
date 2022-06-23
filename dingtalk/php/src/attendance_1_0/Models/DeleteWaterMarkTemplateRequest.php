<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteWaterMarkTemplateRequest extends Model
{
    /**
     * @description 模板的表单Code。
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 模板的内容。
     *
     * @var string
     */
    public $formContent;

    /**
     * @description 群会话ID。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 是否是系统模板。
     * - false：否
     *
     *
     * @var bool
     */
    public $systemTemplate;

    /**
     * @description 用户的userid。
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
