<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckinRecordByUserResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckinRecordByUserResponseBody\result\pageList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $nextToken;

    /**
     * @var pageList[]
     */
    public $pageList;
    protected $_name = [
        'nextToken' => 'nextToken',
        'pageList' => 'pageList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->pageList) {
            $res['pageList'] = [];
            if (null !== $this->pageList && \is_array($this->pageList)) {
                $n = 0;
                foreach ($this->pageList as $item) {
                    $res['pageList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['pageList'])) {
            if (!empty($map['pageList'])) {
                $model->pageList = [];
                $n = 0;
                foreach ($map['pageList'] as $item) {
                    $model->pageList[$n++] = null !== $item ? pageList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
