<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetGroupLiveListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetGroupLiveListResponseBody\result\groupLiveList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var groupLiveList[]
     */
    public $groupLiveList;
    protected $_name = [
        'groupLiveList' => 'groupLiveList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupLiveList) {
            $res['groupLiveList'] = [];
            if (null !== $this->groupLiveList && \is_array($this->groupLiveList)) {
                $n = 0;
                foreach ($this->groupLiveList as $item) {
                    $res['groupLiveList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['groupLiveList'])) {
            if (!empty($map['groupLiveList'])) {
                $model->groupLiveList = [];
                $n = 0;
                foreach ($map['groupLiveList'] as $item) {
                    $model->groupLiveList[$n++] = null !== $item ? groupLiveList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
