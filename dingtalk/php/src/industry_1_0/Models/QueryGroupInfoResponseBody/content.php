<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponseBody\content\extendInfos;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponseBody\content\group;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 扩展信息
     *
     * @var extendInfos[]
     */
    public $extendInfos;

    /**
     * @description 医疗组
     *
     * @var group
     */
    public $group;
    protected $_name = [
        'extendInfos' => 'extendInfos',
        'group'       => 'group',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extendInfos) {
            $res['extendInfos'] = [];
            if (null !== $this->extendInfos && \is_array($this->extendInfos)) {
                $n = 0;
                foreach ($this->extendInfos as $item) {
                    $res['extendInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->group) {
            $res['group'] = null !== $this->group ? $this->group->toMap() : null;
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
        if (isset($map['extendInfos'])) {
            if (!empty($map['extendInfos'])) {
                $model->extendInfos = [];
                $n                  = 0;
                foreach ($map['extendInfos'] as $item) {
                    $model->extendInfos[$n++] = null !== $item ? extendInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['group'])) {
            $model->group = group::fromMap($map['group']);
        }

        return $model;
    }
}
