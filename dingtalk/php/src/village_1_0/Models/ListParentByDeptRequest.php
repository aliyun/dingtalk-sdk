<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListParentByDeptRequest extends Model
{
    /**
     * @description 真实请求的组织corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;
    protected $_name = [
        'subCorpId' => 'subCorpId',
        'deptId'    => 'deptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListParentByDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }

        return $model;
    }
}
