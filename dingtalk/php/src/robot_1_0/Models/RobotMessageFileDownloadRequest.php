<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class RobotMessageFileDownloadRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example mIofN681YE3f/+m+NntqpZSvSH2iMD6xP7Ow/ezdb1Wgn38tqVwL+zoRgzXipAMzmV5uhVKUlBdjKugAIvsm+TrvaPI0JYCMjvFMAlXvMWnMJsi2nZ9a0+N2c9CoV90hiB/B+fEThASPz+jmIa4J6x4WTsmmU3E/AopGsSGugE+hkHBcu52o76Yd2SCpPNUqenvdySSqjowEt1+Ddz55/9Qj8Y8ZhTryqsb7tYwzLFB+F3lsWCotXBOQvEgy3e/bEQtOyV6YrP3KG6YNSb3Q==
     *
     * @var string
     */
    public $downloadCode;

    /**
     * @description This parameter is required.
     *
     * @example dingue4kfzdxbyn0pjqd
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'downloadCode' => 'downloadCode',
        'robotCode' => 'robotCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadCode) {
            $res['downloadCode'] = $this->downloadCode;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RobotMessageFileDownloadRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadCode'])) {
            $model->downloadCode = $map['downloadCode'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
