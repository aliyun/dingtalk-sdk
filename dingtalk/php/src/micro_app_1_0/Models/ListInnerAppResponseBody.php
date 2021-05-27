<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppResponseBody\appList;
use AlibabaCloud\Tea\Model;

class ListInnerAppResponseBody extends Model
{
    /**
     * @description 应用列表
     *
     * @var appList[]
     */
    public $appList;
    protected $_name = [
        'appList' => 'appList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appList) {
            $res['appList'] = [];
            if (null !== $this->appList && \is_array($this->appList)) {
                $n = 0;
                foreach ($this->appList as $item) {
                    $res['appList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListInnerAppResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appList'])) {
            if (!empty($map['appList'])) {
                $model->appList = [];
                $n              = 0;
                foreach ($map['appList'] as $item) {
                    $model->appList[$n++] = null !== $item ? appList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
