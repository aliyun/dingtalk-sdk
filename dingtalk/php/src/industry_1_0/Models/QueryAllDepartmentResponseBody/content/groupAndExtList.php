<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\groupAndExtList\extendInfos;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\groupAndExtList\group;
use AlibabaCloud\Tea\Model;

class groupAndExtList extends Model
{
    /**
     * @description 医疗组详细信息
     *
     * @var group
     */
    public $group;

    /**
     * @description 医疗组扩展信息列表
     *
     * @var extendInfos[]
     */
    public $extendInfos;
    protected $_name = [
        'group'       => 'group',
        'extendInfos' => 'extendInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->group) {
            $res['group'] = null !== $this->group ? $this->group->toMap() : null;
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
     * @return groupAndExtList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['group'])) {
            $model->group = group::fromMap($map['group']);
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
