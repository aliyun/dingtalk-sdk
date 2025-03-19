<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryKitOpenRecordRequest extends Model
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
     * @example course
     *
     * @var string
     */
    public $isvProductScene;
    protected $_name = [
        'corpId' => 'corpId',
        'isvCode' => 'isvCode',
        'isvProductScene' => 'isvProductScene',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->isvProductScene) {
            $res['isvProductScene'] = $this->isvProductScene;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryKitOpenRecordRequest
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
        if (isset($map['isvProductScene'])) {
            $model->isvProductScene = $map['isvProductScene'];
        }

        return $model;
    }
}
