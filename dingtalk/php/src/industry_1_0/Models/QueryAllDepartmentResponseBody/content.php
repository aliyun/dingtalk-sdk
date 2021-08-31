<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\deptAndExt;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\groupAndExtList;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 科室ID
     *
     * @var int
     */
    public $id;

    /**
     * @description 科室名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 科室详情
     *
     * @var deptAndExt
     */
    public $deptAndExt;

    /**
     * @description 医疗组列表
     *
     * @var groupAndExtList[]
     */
    public $groupAndExtList;
    protected $_name = [
        'id'              => 'id',
        'name'            => 'name',
        'deptAndExt'      => 'deptAndExt',
        'groupAndExtList' => 'groupAndExtList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->deptAndExt) {
            $res['deptAndExt'] = null !== $this->deptAndExt ? $this->deptAndExt->toMap() : null;
        }
        if (null !== $this->groupAndExtList) {
            $res['groupAndExtList'] = [];
            if (null !== $this->groupAndExtList && \is_array($this->groupAndExtList)) {
                $n = 0;
                foreach ($this->groupAndExtList as $item) {
                    $res['groupAndExtList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['deptAndExt'])) {
            $model->deptAndExt = deptAndExt::fromMap($map['deptAndExt']);
        }
        if (isset($map['groupAndExtList'])) {
            if (!empty($map['groupAndExtList'])) {
                $model->groupAndExtList = [];
                $n                      = 0;
                foreach ($map['groupAndExtList'] as $item) {
                    $model->groupAndExtList[$n++] = null !== $item ? groupAndExtList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
