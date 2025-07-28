<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $clueId;

    /**
     * @var string
     */
    public $dataId;

    /**
     * @var string
     */
    public $resultCode;
    protected $_name = [
        'clueId' => 'clueId',
        'dataId' => 'dataId',
        'resultCode' => 'resultCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->clueId) {
            $res['clueId'] = $this->clueId;
        }
        if (null !== $this->dataId) {
            $res['dataId'] = $this->dataId;
        }
        if (null !== $this->resultCode) {
            $res['resultCode'] = $this->resultCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['clueId'])) {
            $model->clueId = $map['clueId'];
        }
        if (isset($map['dataId'])) {
            $model->dataId = $map['dataId'];
        }
        if (isset($map['resultCode'])) {
            $model->resultCode = $map['resultCode'];
        }

        return $model;
    }
}
