<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataRequest\triggerDataList;
use AlibabaCloud\Tea\Model;

class SyncDataRequest extends Model
{
    /**
     * @description 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
     *
     * @var string
     */
    public $appId;

    /**
     * @var triggerDataList[]
     */
    public $triggerDataList;
    protected $_name = [
        'appId'           => 'appId',
        'triggerDataList' => 'triggerDataList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->triggerDataList) {
            $res['triggerDataList'] = [];
            if (null !== $this->triggerDataList && \is_array($this->triggerDataList)) {
                $n = 0;
                foreach ($this->triggerDataList as $item) {
                    $res['triggerDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['triggerDataList'])) {
            if (!empty($map['triggerDataList'])) {
                $model->triggerDataList = [];
                $n                      = 0;
                foreach ($map['triggerDataList'] as $item) {
                    $model->triggerDataList[$n++] = null !== $item ? triggerDataList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
