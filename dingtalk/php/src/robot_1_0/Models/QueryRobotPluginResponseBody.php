<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryRobotPluginResponseBody\pluginInfoList;
use AlibabaCloud\Tea\Model;

class QueryRobotPluginResponseBody extends Model
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
     * @return QueryRobotPluginResponseBody
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
