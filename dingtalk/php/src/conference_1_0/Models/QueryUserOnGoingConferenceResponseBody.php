<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserOnGoingConferenceResponseBody extends Model
{
    /**
     * @var MemberModelMapValue[]
     */
    public $memberModelMap;

    /**
     * @var string[]
     */
    public $onGoingConfIdList;
    protected $_name = [
        'memberModelMap'    => 'memberModelMap',
        'onGoingConfIdList' => 'onGoingConfIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberModelMap) {
            $res['memberModelMap'] = [];
            if (null !== $this->memberModelMap && \is_array($this->memberModelMap)) {
                foreach ($this->memberModelMap as $key => $val) {
                    $res['memberModelMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->onGoingConfIdList) {
            $res['onGoingConfIdList'] = $this->onGoingConfIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserOnGoingConferenceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberModelMap'])) {
            $model->memberModelMap = $map['memberModelMap'];
        }
        if (isset($map['onGoingConfIdList'])) {
            if (!empty($map['onGoingConfIdList'])) {
                $model->onGoingConfIdList = $map['onGoingConfIdList'];
            }
        }

        return $model;
    }
}
