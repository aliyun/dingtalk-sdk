<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelMetaResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelMetaResponseBody\content\labelMetas;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var labelMetas[]
     */
    public $labelMetas;

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
        'labelMetas' => 'labelMetas',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelMetas) {
            $res['labelMetas'] = [];
            if (null !== $this->labelMetas && \is_array($this->labelMetas)) {
                $n = 0;
                foreach ($this->labelMetas as $item) {
                    $res['labelMetas'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['labelMetas'])) {
            if (!empty($map['labelMetas'])) {
                $model->labelMetas = [];
                $n = 0;
                foreach ($map['labelMetas'] as $item) {
                    $model->labelMetas[$n++] = null !== $item ? labelMetas::fromMap($item) : $item;
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
