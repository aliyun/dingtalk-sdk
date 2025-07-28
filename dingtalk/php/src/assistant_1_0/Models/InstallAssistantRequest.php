<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class InstallAssistantRequest extends Model
{
    /**
     * @var string
     */
    public $assistantId;

    /**
     * @var bool
     */
    public $isAllOrgMemberVisible;
    protected $_name = [
        'assistantId' => 'assistantId',
        'isAllOrgMemberVisible' => 'isAllOrgMemberVisible',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->isAllOrgMemberVisible) {
            $res['isAllOrgMemberVisible'] = $this->isAllOrgMemberVisible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InstallAssistantRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['isAllOrgMemberVisible'])) {
            $model->isAllOrgMemberVisible = $map['isAllOrgMemberVisible'];
        }

        return $model;
    }
}
