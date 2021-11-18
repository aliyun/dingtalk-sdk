<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class StartCoursePrepareRequest extends Model
{
    /**
     * @description 拓展信息
     *
     * @var string
     */
    public $ext;

    /**
     * @description 课程组编号
     *
     * @var string
     */
    public $courseGroupCode;

    /**
     * @description 课节信息
     *
     * @var int[]
     */
    public $sectionIndex;

    /**
     * @description 设备id
     *
     * @var string
     */
    public $deviceId;

    /**
     * @description 封面url
     *
     * @var string
     */
    public $liveCoverImage;

    /**
     * @description 上课日期
     *
     * @var string
     */
    public $courseDate;

    /**
     * @description isv编号
     *
     * @var string
     */
    public $isvCode;

    /**
     * @description 操作人
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'ext'             => 'ext',
        'courseGroupCode' => 'courseGroupCode',
        'sectionIndex'    => 'sectionIndex',
        'deviceId'        => 'deviceId',
        'liveCoverImage'  => 'liveCoverImage',
        'courseDate'      => 'courseDate',
        'isvCode'         => 'isvCode',
        'opUserId'        => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->courseGroupCode) {
            $res['courseGroupCode'] = $this->courseGroupCode;
        }
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->liveCoverImage) {
            $res['liveCoverImage'] = $this->liveCoverImage;
        }
        if (null !== $this->courseDate) {
            $res['courseDate'] = $this->courseDate;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StartCoursePrepareRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['courseGroupCode'])) {
            $model->courseGroupCode = $map['courseGroupCode'];
        }
        if (isset($map['sectionIndex'])) {
            if (!empty($map['sectionIndex'])) {
                $model->sectionIndex = $map['sectionIndex'];
            }
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['liveCoverImage'])) {
            $model->liveCoverImage = $map['liveCoverImage'];
        }
        if (isset($map['courseDate'])) {
            $model->courseDate = $map['courseDate'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
