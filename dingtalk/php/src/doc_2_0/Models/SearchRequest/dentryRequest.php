<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest\dentryRequest\visitTimeRange;
use AlibabaCloud\Tea\Model;

class dentryRequest extends Model
{
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
    public $searchField;

    /**
     * @var int
     */
    public $searchFileType;

    /**
     * @var string
     */
    public $spaceId;

    /**
     * @example 40
     *
     * @var int
     */
    public $summaryLength;

    /**
     * @var visitTimeRange
     */
    public $visitTimeRange;
    protected $_name = [
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'searchField'    => 'searchField',
        'searchFileType' => 'searchFileType',
        'spaceId'        => 'spaceId',
        'summaryLength'  => 'summaryLength',
        'visitTimeRange' => 'visitTimeRange',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->searchField) {
            $res['searchField'] = $this->searchField;
        }
        if (null !== $this->searchFileType) {
            $res['searchFileType'] = $this->searchFileType;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->summaryLength) {
            $res['summaryLength'] = $this->summaryLength;
        }
        if (null !== $this->visitTimeRange) {
            $res['visitTimeRange'] = null !== $this->visitTimeRange ? $this->visitTimeRange->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['searchField'])) {
            $model->searchField = $map['searchField'];
        }
        if (isset($map['searchFileType'])) {
            $model->searchFileType = $map['searchFileType'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['summaryLength'])) {
            $model->summaryLength = $map['summaryLength'];
        }
        if (isset($map['visitTimeRange'])) {
            $model->visitTimeRange = visitTimeRange::fromMap($map['visitTimeRange']);
        }

        return $model;
    }
}
