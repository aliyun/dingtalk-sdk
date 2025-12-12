<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteCustomRosterFieldRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $groupId;
    protected $_name = [
        'fieldCode' => 'fieldCode',
        'groupId' => 'groupId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteCustomRosterFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }

        return $model;
    }
}
