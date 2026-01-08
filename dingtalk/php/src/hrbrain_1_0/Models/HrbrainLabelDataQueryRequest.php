<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainLabelDataQueryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $labelCode;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'labelCode' => 'labelCode',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelCode) {
            $res['labelCode'] = $this->labelCode;
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
     * @return HrbrainLabelDataQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelCode'])) {
            $model->labelCode = $map['labelCode'];
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
