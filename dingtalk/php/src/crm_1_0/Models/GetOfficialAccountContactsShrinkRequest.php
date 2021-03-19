<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOfficialAccountContactsShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $contextShrink;

    /**
     * @description 取数游标，第一次传0
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 分页大小，最大不超过10
     *
     * @var int
     */
    public $maxResults;
    protected $_name = [
        'contextShrink' => 'context',
        'nextToken'     => 'nextToken',
        'maxResults'    => 'maxResults',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contextShrink) {
            $res['context'] = $this->contextShrink;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOfficialAccountContactsShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['context'])) {
            $model->contextShrink = $map['context'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }

        return $model;
    }
}
