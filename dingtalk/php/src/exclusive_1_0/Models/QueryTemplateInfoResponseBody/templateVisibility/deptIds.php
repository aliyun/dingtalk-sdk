<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\templateVisibility;

use AlibabaCloud\Tea\Model;

class deptIds extends Model
{
    /**
     * @var string
     */
    public $deptId;

    /**
     * @var string
     */
    public $deptName;
    protected $_name = [
        'deptId' => 'deptId',
        'deptName' => 'deptName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptIds
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }

        return $model;
    }
}
