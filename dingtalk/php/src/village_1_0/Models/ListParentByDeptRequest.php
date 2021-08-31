<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListParentByDeptRequest extends Model
{
    /**
     * @description 下属组织的组织ID，比如下属镇、村的corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 下属组织的部门ID
     *
     * @var int
     */
    public $departmentId;
    protected $_name = [
        'subCorpId'    => 'subCorpId',
        'departmentId' => 'departmentId',
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
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
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
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }

        return $model;
    }
}
