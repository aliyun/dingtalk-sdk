<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO;
use AlibabaCloud\Tea\Model;

class CreateResumeRequest extends Model
{
    /**
     * @var string
     */
    public $bizCode;

    /**
     * @var string
     */
    public $ext;

    /**
     * @var resumeDataVO
     */
    public $resumeDataVO;

    /**
     * @var string
     */
    public $scene;

    /**
     * @var string[]
     */
    public $types;

    /**
     * @var string
     */
    public $userIdentify;
    protected $_name = [
        'bizCode'      => 'bizCode',
        'ext'          => 'ext',
        'resumeDataVO' => 'resumeDataVO',
        'scene'        => 'scene',
        'types'        => 'types',
        'userIdentify' => 'userIdentify',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->resumeDataVO) {
            $res['resumeDataVO'] = null !== $this->resumeDataVO ? $this->resumeDataVO->toMap() : null;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->types) {
            $res['types'] = $this->types;
        }
        if (null !== $this->userIdentify) {
            $res['userIdentify'] = $this->userIdentify;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateResumeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['resumeDataVO'])) {
            $model->resumeDataVO = resumeDataVO::fromMap($map['resumeDataVO']);
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['types'])) {
            if (!empty($map['types'])) {
                $model->types = $map['types'];
            }
        }
        if (isset($map['userIdentify'])) {
            $model->userIdentify = $map['userIdentify'];
        }

        return $model;
    }
}
