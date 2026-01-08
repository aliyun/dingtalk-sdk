<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSummaryResponseBody\aiSummaryList;
use AlibabaCloud\Tea\Model;

class QuerySmartDeviceAiSummaryResponseBody extends Model
{
    /**
     * @var aiSummaryList[]
     */
    public $aiSummaryList;

    /**
     * @var int
     */
    public $state;
    protected $_name = [
        'aiSummaryList' => 'aiSummaryList',
        'state' => 'state',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiSummaryList) {
            $res['aiSummaryList'] = [];
            if (null !== $this->aiSummaryList && \is_array($this->aiSummaryList)) {
                $n = 0;
                foreach ($this->aiSummaryList as $item) {
                    $res['aiSummaryList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySmartDeviceAiSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aiSummaryList'])) {
            if (!empty($map['aiSummaryList'])) {
                $model->aiSummaryList = [];
                $n = 0;
                foreach ($map['aiSummaryList'] as $item) {
                    $model->aiSummaryList[$n++] = null !== $item ? aiSummaryList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
