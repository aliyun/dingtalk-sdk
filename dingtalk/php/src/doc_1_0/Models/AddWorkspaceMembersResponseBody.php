<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddWorkspaceMembersResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $notInOrgList;
    protected $_name = [
        'notInOrgList' => 'notInOrgList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->notInOrgList) {
            $res['notInOrgList'] = $this->notInOrgList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddWorkspaceMembersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['notInOrgList'])) {
            if (!empty($map['notInOrgList'])) {
                $model->notInOrgList = $map['notInOrgList'];
            }
        }

        return $model;
    }
}
