<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoByRoomCodeResponseBody\conferenceList;
use AlibabaCloud\Tea\Model;

class QueryConferenceInfoByRoomCodeResponseBody extends Model
{
    /**
     * @var conferenceList[]
     */
    public $conferenceList;

    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'conferenceList' => 'conferenceList',
        'hasMore'        => 'hasMore',
        'nextToken'      => 'nextToken',
        'totalCount'     => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conferenceList) {
            $res['conferenceList'] = [];
            if (null !== $this->conferenceList && \is_array($this->conferenceList)) {
                $n = 0;
                foreach ($this->conferenceList as $item) {
                    $res['conferenceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryConferenceInfoByRoomCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conferenceList'])) {
            if (!empty($map['conferenceList'])) {
                $model->conferenceList = [];
                $n                     = 0;
                foreach ($map['conferenceList'] as $item) {
                    $model->conferenceList[$n++] = null !== $item ? conferenceList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
