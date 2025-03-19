<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\UpdateAssistantScopeRequest\scopes;
use AlibabaCloud\Tea\Model;

class UpdateAssistantScopeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $assistantId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorUnionId;

    /**
     * @var scopes
     */
    public $scopes;

    /**
     * @var bool
     */
    public $sharing;
    protected $_name = [
        'assistantId' => 'assistantId',
        'operatorUnionId' => 'operatorUnionId',
        'scopes' => 'scopes',
        'sharing' => 'sharing',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }
        if (null !== $this->scopes) {
            $res['scopes'] = null !== $this->scopes ? $this->scopes->toMap() : null;
        }
        if (null !== $this->sharing) {
            $res['sharing'] = $this->sharing;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAssistantScopeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }
        if (isset($map['scopes'])) {
            $model->scopes = scopes::fromMap($map['scopes']);
        }
        if (isset($map['sharing'])) {
            $model->sharing = $map['sharing'];
        }

        return $model;
    }
}
