<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupFromOldGroupRequest extends Model
{
    /**
     * @var int
     */
    public $notQuitWhenEmpLeave;

    /**
     * @var string
     */
    public $srcCorpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $srcOpenConversationId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $templateId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'notQuitWhenEmpLeave' => 'notQuitWhenEmpLeave',
        'srcCorpId' => 'srcCorpId',
        'srcOpenConversationId' => 'srcOpenConversationId',
        'templateId' => 'templateId',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->notQuitWhenEmpLeave) {
            $res['notQuitWhenEmpLeave'] = $this->notQuitWhenEmpLeave;
        }
        if (null !== $this->srcCorpId) {
            $res['srcCorpId'] = $this->srcCorpId;
        }
        if (null !== $this->srcOpenConversationId) {
            $res['srcOpenConversationId'] = $this->srcOpenConversationId;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupFromOldGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['notQuitWhenEmpLeave'])) {
            $model->notQuitWhenEmpLeave = $map['notQuitWhenEmpLeave'];
        }
        if (isset($map['srcCorpId'])) {
            $model->srcCorpId = $map['srcCorpId'];
        }
        if (isset($map['srcOpenConversationId'])) {
            $model->srcOpenConversationId = $map['srcOpenConversationId'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
