<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTransferCourseRequest extends Model
{
    /**
     * @example dingxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example ISV_XXX
     *
     * @var string
     */
    public $isvCode;

    /**
     * @example recordId
     *
     * @var string
     */
    public $isvRecordId;
    protected $_name = [
        'corpId'      => 'corpId',
        'isvCode'     => 'isvCode',
        'isvRecordId' => 'isvRecordId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->isvRecordId) {
            $res['isvRecordId'] = $this->isvRecordId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTransferCourseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['isvRecordId'])) {
            $model->isvRecordId = $map['isvRecordId'];
        }

        return $model;
    }
}
