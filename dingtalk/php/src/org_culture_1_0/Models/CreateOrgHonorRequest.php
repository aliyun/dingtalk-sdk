<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateOrgHonorRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example $xxxxxxx
     *
     * @var string
     */
    public $avatarFrameMediaId;

    /**
     * @description This parameter is required.
     *
     * @example #FFFBB4
     *
     * @var string
     */
    public $defaultBgColor;

    /**
     * @description This parameter is required.
     *
     * @example 客户服务用心，奖励荣誉
     *
     * @var string
     */
    public $medalDesc;

    /**
     * @description This parameter is required.
     *
     * @example @xxxxxxx
     *
     * @var string
     */
    public $medalMediaId;

    /**
     * @description This parameter is required.
     *
     * @example 客户第一
     *
     * @var string
     */
    public $medalName;

    /**
     * @description This parameter is required.
     *
     * @example 12312312
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'avatarFrameMediaId' => 'avatarFrameMediaId',
        'defaultBgColor'     => 'defaultBgColor',
        'medalDesc'          => 'medalDesc',
        'medalMediaId'       => 'medalMediaId',
        'medalName'          => 'medalName',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarFrameMediaId) {
            $res['avatarFrameMediaId'] = $this->avatarFrameMediaId;
        }
        if (null !== $this->defaultBgColor) {
            $res['defaultBgColor'] = $this->defaultBgColor;
        }
        if (null !== $this->medalDesc) {
            $res['medalDesc'] = $this->medalDesc;
        }
        if (null !== $this->medalMediaId) {
            $res['medalMediaId'] = $this->medalMediaId;
        }
        if (null !== $this->medalName) {
            $res['medalName'] = $this->medalName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateOrgHonorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarFrameMediaId'])) {
            $model->avatarFrameMediaId = $map['avatarFrameMediaId'];
        }
        if (isset($map['defaultBgColor'])) {
            $model->defaultBgColor = $map['defaultBgColor'];
        }
        if (isset($map['medalDesc'])) {
            $model->medalDesc = $map['medalDesc'];
        }
        if (isset($map['medalMediaId'])) {
            $model->medalMediaId = $map['medalMediaId'];
        }
        if (isset($map['medalName'])) {
            $model->medalName = $map['medalName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
