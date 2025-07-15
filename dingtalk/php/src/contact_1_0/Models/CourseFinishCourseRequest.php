<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class CourseFinishCourseRequest extends Model
{
    /**
     * @example isv_code_cert_id_001
     *
     * @var string
     */
    public $certId;

    /**
     * @example data:image\/(?:png|jpeg|gif|bmp|webp);base64
     *
     * @var string
     */
    public $certMediaBase64;

    /**
     * @example isv_code_course_01
     *
     * @var string
     */
    public $courseId;

    /**
     * @example pass
     *
     * @var string
     */
    public $status;

    /**
     * @example xxxxx001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'certId' => 'certId',
        'certMediaBase64' => 'certMediaBase64',
        'courseId' => 'courseId',
        'status' => 'status',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->certId) {
            $res['certId'] = $this->certId;
        }
        if (null !== $this->certMediaBase64) {
            $res['certMediaBase64'] = $this->certMediaBase64;
        }
        if (null !== $this->courseId) {
            $res['courseId'] = $this->courseId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CourseFinishCourseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['certId'])) {
            $model->certId = $map['certId'];
        }
        if (isset($map['certMediaBase64'])) {
            $model->certMediaBase64 = $map['certMediaBase64'];
        }
        if (isset($map['courseId'])) {
            $model->courseId = $map['courseId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
