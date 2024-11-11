<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryKitOpenRecordResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example {""}
     *
     * @var string
     */
    public $attributes;

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
     * @example 0
     *
     * @var int
     */
    public $openEndTime;

    /**
     * @example 0
     *
     * @var int
     */
    public $openStartTime;

    /**
     * @example staffxxx
     *
     * @var string
     */
    public $openUserId;
    protected $_name = [
        'attributes'      => 'attributes',
        'corpId'          => 'corpId',
        'isvCode'         => 'isvCode',
        'isvProductScene' => 'isvProductScene',
        'openEndTime'     => 'openEndTime',
        'openStartTime'   => 'openStartTime',
        'openUserId'      => 'openUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->isvProductScene) {
            $res['isvProductScene'] = $this->isvProductScene;
        }
        if (null !== $this->openEndTime) {
            $res['openEndTime'] = $this->openEndTime;
        }
        if (null !== $this->openStartTime) {
            $res['openStartTime'] = $this->openStartTime;
        }
        if (null !== $this->openUserId) {
            $res['openUserId'] = $this->openUserId;
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
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['isvProductScene'])) {
            $model->isvProductScene = $map['isvProductScene'];
        }
        if (isset($map['openEndTime'])) {
            $model->openEndTime = $map['openEndTime'];
        }
        if (isset($map['openStartTime'])) {
            $model->openStartTime = $map['openStartTime'];
        }
        if (isset($map['openUserId'])) {
            $model->openUserId = $map['openUserId'];
        }

        return $model;
    }
}
