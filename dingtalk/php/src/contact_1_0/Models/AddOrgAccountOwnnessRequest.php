<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOrgAccountOwnnessRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1698335999000
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $ownenssType;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var int
     */
    public $ownnessId;

    /**
     * @description This parameter is required.
     *
     * @example 1698335999000
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example 会议中
     *
     * @var string
     */
    public $text;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'endTime'     => 'endTime',
        'ownenssType' => 'ownenssType',
        'ownnessId'   => 'ownnessId',
        'startTime'   => 'startTime',
        'text'        => 'text',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->ownenssType) {
            $res['ownenssType'] = $this->ownenssType;
        }
        if (null !== $this->ownnessId) {
            $res['ownnessId'] = $this->ownnessId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddOrgAccountOwnnessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['ownenssType'])) {
            $model->ownenssType = $map['ownenssType'];
        }
        if (isset($map['ownnessId'])) {
            $model->ownnessId = $map['ownnessId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
