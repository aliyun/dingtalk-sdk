<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CustomizeContactEmpDeleteRequest extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @example 65722123
     *
     * @var int
     */
    public $deptId;

    /**
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'code'       => 'code',
        'deptId'     => 'deptId',
        'userIdList' => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomizeContactEmpDeleteRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
