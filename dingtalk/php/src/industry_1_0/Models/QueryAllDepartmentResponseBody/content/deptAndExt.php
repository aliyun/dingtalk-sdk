<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\deptAndExt\department;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\deptAndExt\extendInfos;
use AlibabaCloud\Tea\Model;

class deptAndExt extends Model
{
    /**
     * @description 科室详情
     *
     * @var department
     */
    public $department;

    /**
     * @description 科室扩展信息列表
     *
     * @var extendInfos[]
     */
    public $extendInfos;
    protected $_name = [
        'department'  => 'department',
        'extendInfos' => 'extendInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->department) {
            $res['department'] = null !== $this->department ? $this->department->toMap() : null;
        }
        if (null !== $this->extendInfos) {
            $res['extendInfos'] = [];
            if (null !== $this->extendInfos && \is_array($this->extendInfos)) {
                $n = 0;
                foreach ($this->extendInfos as $item) {
                    $res['extendInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptAndExt
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['department'])) {
            $model->department = department::fromMap($map['department']);
        }
        if (isset($map['extendInfos'])) {
            if (!empty($map['extendInfos'])) {
                $model->extendInfos = [];
                $n                  = 0;
                foreach ($map['extendInfos'] as $item) {
                    $model->extendInfos[$n++] = null !== $item ? extendInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
