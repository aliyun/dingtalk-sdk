<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesRequest;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesRequest\option\createTimeRange;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesRequest\option\visitTimeRange;
use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @var createTimeRange
     */
    public $createTimeRange;

    /**
     * @var string[]
     */
    public $creatorIds;

    /**
     * @var string[]
     */
    public $dentryCategories;

    /**
     * @example 20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @var string[]
     */
    public $modifierIds;

    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @var int[]
     */
    public $spaceIds;

    /**
     * @var visitTimeRange
     */
    public $visitTimeRange;
    protected $_name = [
        'createTimeRange'  => 'createTimeRange',
        'creatorIds'       => 'creatorIds',
        'dentryCategories' => 'dentryCategories',
        'maxResults'       => 'maxResults',
        'modifierIds'      => 'modifierIds',
        'nextToken'        => 'nextToken',
        'spaceIds'         => 'spaceIds',
        'visitTimeRange'   => 'visitTimeRange',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTimeRange) {
            $res['createTimeRange'] = null !== $this->createTimeRange ? $this->createTimeRange->toMap() : null;
        }
        if (null !== $this->creatorIds) {
            $res['creatorIds'] = $this->creatorIds;
        }
        if (null !== $this->dentryCategories) {
            $res['dentryCategories'] = $this->dentryCategories;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->modifierIds) {
            $res['modifierIds'] = $this->modifierIds;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->spaceIds) {
            $res['spaceIds'] = $this->spaceIds;
        }
        if (null !== $this->visitTimeRange) {
            $res['visitTimeRange'] = null !== $this->visitTimeRange ? $this->visitTimeRange->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTimeRange'])) {
            $model->createTimeRange = createTimeRange::fromMap($map['createTimeRange']);
        }
        if (isset($map['creatorIds'])) {
            if (!empty($map['creatorIds'])) {
                $model->creatorIds = $map['creatorIds'];
            }
        }
        if (isset($map['dentryCategories'])) {
            if (!empty($map['dentryCategories'])) {
                $model->dentryCategories = $map['dentryCategories'];
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['modifierIds'])) {
            if (!empty($map['modifierIds'])) {
                $model->modifierIds = $map['modifierIds'];
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['spaceIds'])) {
            if (!empty($map['spaceIds'])) {
                $model->spaceIds = $map['spaceIds'];
            }
        }
        if (isset($map['visitTimeRange'])) {
            $model->visitTimeRange = visitTimeRange::fromMap($map['visitTimeRange']);
        }

        return $model;
    }
}
