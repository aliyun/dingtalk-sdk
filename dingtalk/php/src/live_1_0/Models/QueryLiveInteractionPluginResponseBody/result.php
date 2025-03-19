<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInteractionPluginResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInteractionPluginResponseBody\result\livePluginList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var livePluginList[]
     */
    public $livePluginList;
    protected $_name = [
        'livePluginList' => 'livePluginList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->livePluginList) {
            $res['livePluginList'] = [];
            if (null !== $this->livePluginList && \is_array($this->livePluginList)) {
                $n = 0;
                foreach ($this->livePluginList as $item) {
                    $res['livePluginList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['livePluginList'])) {
            if (!empty($map['livePluginList'])) {
                $model->livePluginList = [];
                $n = 0;
                foreach ($map['livePluginList'] as $item) {
                    $model->livePluginList[$n++] = null !== $item ? livePluginList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
