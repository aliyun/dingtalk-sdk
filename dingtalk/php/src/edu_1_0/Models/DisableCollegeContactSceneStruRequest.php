<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DisableCollegeContactSceneStruRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 20
     *
     * @var int
     */
    public $struId;
    protected $_name = [
        'struId' => 'struId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->struId) {
            $res['struId'] = $this->struId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DisableCollegeContactSceneStruRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['struId'])) {
            $model->struId = $map['struId'];
        }

        return $model;
    }
}
