<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAclsResponseBody\acls;
use AlibabaCloud\Tea\Model;

class ListAclsResponseBody extends Model
{
    /**
     * @description 访问控制列表
     *
     * @var acls[]
     */
    public $acls;
    protected $_name = [
        'acls' => 'acls',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->acls) {
            $res['acls'] = [];
            if (null !== $this->acls && \is_array($this->acls)) {
                $n = 0;
                foreach ($this->acls as $item) {
                    $res['acls'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAclsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['acls'])) {
            if (!empty($map['acls'])) {
                $model->acls = [];
                $n           = 0;
                foreach ($map['acls'] as $item) {
                    $model->acls[$n++] = null !== $item ? acls::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
