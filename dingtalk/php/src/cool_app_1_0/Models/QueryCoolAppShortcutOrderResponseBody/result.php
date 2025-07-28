<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models\QueryCoolAppShortcutOrderResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models\QueryCoolAppShortcutOrderResponseBody\result\forbiddenPluginList;
use AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models\QueryCoolAppShortcutOrderResponseBody\result\myPluginList;
use AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models\QueryCoolAppShortcutOrderResponseBody\result\otherPluginList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var forbiddenPluginList[]
     */
    public $forbiddenPluginList;

    /**
     * @var myPluginList[]
     */
    public $myPluginList;

    /**
     * @var otherPluginList[]
     */
    public $otherPluginList;
    protected $_name = [
        'forbiddenPluginList' => 'forbiddenPluginList',
        'myPluginList' => 'myPluginList',
        'otherPluginList' => 'otherPluginList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->forbiddenPluginList) {
            $res['forbiddenPluginList'] = [];
            if (null !== $this->forbiddenPluginList && \is_array($this->forbiddenPluginList)) {
                $n = 0;
                foreach ($this->forbiddenPluginList as $item) {
                    $res['forbiddenPluginList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->myPluginList) {
            $res['myPluginList'] = [];
            if (null !== $this->myPluginList && \is_array($this->myPluginList)) {
                $n = 0;
                foreach ($this->myPluginList as $item) {
                    $res['myPluginList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->otherPluginList) {
            $res['otherPluginList'] = [];
            if (null !== $this->otherPluginList && \is_array($this->otherPluginList)) {
                $n = 0;
                foreach ($this->otherPluginList as $item) {
                    $res['otherPluginList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['forbiddenPluginList'])) {
            if (!empty($map['forbiddenPluginList'])) {
                $model->forbiddenPluginList = [];
                $n = 0;
                foreach ($map['forbiddenPluginList'] as $item) {
                    $model->forbiddenPluginList[$n++] = null !== $item ? forbiddenPluginList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['myPluginList'])) {
            if (!empty($map['myPluginList'])) {
                $model->myPluginList = [];
                $n = 0;
                foreach ($map['myPluginList'] as $item) {
                    $model->myPluginList[$n++] = null !== $item ? myPluginList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['otherPluginList'])) {
            if (!empty($map['otherPluginList'])) {
                $model->otherPluginList = [];
                $n = 0;
                foreach ($map['otherPluginList'] as $item) {
                    $model->otherPluginList[$n++] = null !== $item ? otherPluginList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
