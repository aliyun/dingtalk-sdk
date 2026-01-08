<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelDataQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelDataQueryResponseBody\content\labelDatas;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var labelDatas[]
     */
    public $labelDatas;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'labelDatas' => 'labelDatas',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelDatas) {
            $res['labelDatas'] = [];
            if (null !== $this->labelDatas && \is_array($this->labelDatas)) {
                $n = 0;
                foreach ($this->labelDatas as $item) {
                    $res['labelDatas'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
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
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelDatas'])) {
            if (!empty($map['labelDatas'])) {
                $model->labelDatas = [];
                $n = 0;
                foreach ($map['labelDatas'] as $item) {
                    $model->labelDatas[$n++] = null !== $item ? labelDatas::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
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
