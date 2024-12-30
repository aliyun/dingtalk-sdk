<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractExtractTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $extractTaskId;
    protected $_name = [
        'extractTaskId' => 'extractTaskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extractTaskId) {
            $res['extractTaskId'] = $this->extractTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extractTaskId'])) {
            $model->extractTaskId = $map['extractTaskId'];
        }

        return $model;
    }
}
