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
     * @var string
     */
    public $gmtModifiedEnd;

    /**
     * @var string
     */
    public $gmtModifiedStart;

    /**
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
        'categoryCodes' => 'categoryCodes',
        'gmtModifiedEnd' => 'gmtModifiedEnd',
        'gmtModifiedStart' => 'gmtModifiedStart',
        'labelCode' => 'labelCode',
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
        if (null !== $this->gmtModifiedEnd) {
            $res['gmtModifiedEnd'] = $this->gmtModifiedEnd;
        }
        if (null !== $this->gmtModifiedStart) {
            $res['gmtModifiedStart'] = $this->gmtModifiedStart;
        }
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
        if (isset($map['gmtModifiedEnd'])) {
            $model->gmtModifiedEnd = $map['gmtModifiedEnd'];
        }
        if (isset($map['gmtModifiedStart'])) {
            $model->gmtModifiedStart = $map['gmtModifiedStart'];
        }
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
