<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListOrgPluginsResponseBody\plugins;
use AlibabaCloud\Tea\Model;

class ListOrgPluginsResponseBody extends Model
{
    /**
     * @var plugins[]
     */
    public $plugins;
    protected $_name = [
        'plugins' => 'plugins',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->plugins) {
            $res['plugins'] = [];
            if (null !== $this->plugins && \is_array($this->plugins)) {
                $n = 0;
                foreach ($this->plugins as $item) {
                    $res['plugins'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListOrgPluginsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['plugins'])) {
            if (!empty($map['plugins'])) {
                $model->plugins = [];
                $n = 0;
                foreach ($map['plugins'] as $item) {
                    $model->plugins[$n++] = null !== $item ? plugins::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
