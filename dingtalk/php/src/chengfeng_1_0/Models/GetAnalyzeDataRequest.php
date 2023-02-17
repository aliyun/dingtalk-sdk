<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAnalyzeDataRequest extends Model
{
    /**
     * @description 周期ID列表
     *
     * @var string[]
     */
    public $periodIds;

    /**
     * @description 部门编号(钉钉部门号)
     *
     * @var string
     */
    public $deptId;
    protected $_name = [
        'periodIds' => 'periodIds',
        'deptId'    => 'deptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->periodIds) {
            $res['periodIds'] = $this->periodIds;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAnalyzeDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['periodIds'])) {
            if (!empty($map['periodIds'])) {
                $model->periodIds = $map['periodIds'];
            }
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }

        return $model;
    }
}
