<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class StartCoursePrepareRequest extends Model
{
    /**
     * @example 2021-11-16
     *
     * @var string
     */
    public $courseDate;

    /**
     * @example course1
     *
     * @var string
     */
    public $courseGroupCode;

    /**
     * @example device1
     *
     * @var string
     */
    public $deviceId;

    /**
     * @example extNumber
     *
     * @var string
     */
    public $ext;

    /**
     * @example DDISV
     *
     * @var string
     */
    public $isvCode;

    /**
     * @example ""
     *
     * @var string
     */
    public $liveCoverImage;

    /**
     * @var int[]
     */
    public $sectionIndex;

    /**
     * @example manger1234
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'courseDate'      => 'courseDate',
        'courseGroupCode' => 'courseGroupCode',
        'deviceId'        => 'deviceId',
        'ext'             => 'ext',
        'isvCode'         => 'isvCode',
        'liveCoverImage'  => 'liveCoverImage',
        'sectionIndex'    => 'sectionIndex',
        'opUserId'        => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseDate) {
            $res['courseDate'] = $this->courseDate;
        }
        if (null !== $this->courseGroupCode) {
            $res['courseGroupCode'] = $this->courseGroupCode;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->liveCoverImage) {
            $res['liveCoverImage'] = $this->liveCoverImage;
        }
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
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
        if (isset($map['courseDate'])) {
            $model->courseDate = $map['courseDate'];
        }
        if (isset($map['courseGroupCode'])) {
            $model->courseGroupCode = $map['courseGroupCode'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['liveCoverImage'])) {
            $model->liveCoverImage = $map['liveCoverImage'];
        }
        if (isset($map['sectionIndex'])) {
            if (!empty($map['sectionIndex'])) {
                $model->sectionIndex = $map['sectionIndex'];
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
