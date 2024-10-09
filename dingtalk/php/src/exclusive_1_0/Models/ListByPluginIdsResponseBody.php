<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByPluginIdsResponseBody\pluginInfoList;
use AlibabaCloud\Tea\Model;

class ListByPluginIdsResponseBody extends Model
{
    /**
     * @var pluginInfoList[]
     */
    public $pluginInfoList;
    protected $_name = [
        'pluginInfoList' => 'pluginInfoList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pluginInfoList) {
            $res['pluginInfoList'] = [];
            if (null !== $this->pluginInfoList && \is_array($this->pluginInfoList)) {
                $n = 0;
                foreach ($this->pluginInfoList as $item) {
                    $res['pluginInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListByPluginIdsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pluginInfoList'])) {
            if (!empty($map['pluginInfoList'])) {
                $model->pluginInfoList = [];
                $n                     = 0;
                foreach ($map['pluginInfoList'] as $item) {
                    $model->pluginInfoList[$n++] = null !== $item ? pluginInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
