<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class InvalidKitRequest extends Model
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

    /**
     * @example staffxxx
     *
     * @var string
     */
    public $openUserId;
    protected $_name = [
        'corpId' => 'corpId',
        'isvCode' => 'isvCode',
        'isvProductScene' => 'isvProductScene',
        'openUserId' => 'openUserId',
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
        if (null !== $this->openUserId) {
            $res['openUserId'] = $this->openUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InvalidKitRequest
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
        if (isset($map['openUserId'])) {
            $model->openUserId = $map['openUserId'];
        }

        return $model;
    }
}
