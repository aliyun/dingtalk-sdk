<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainLabelMetaRequest extends Model
{
    /**
     * @var string[]
     */
    public $categoryCodes;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'categoryCodes' => 'categoryCodes',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryCodes) {
            $res['categoryCodes'] = $this->categoryCodes;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainLabelMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryCodes'])) {
            if (!empty($map['categoryCodes'])) {
                $model->categoryCodes = $map['categoryCodes'];
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
