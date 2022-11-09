<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class certificates extends Model
{
    /**
     * @description 证书名称
     *
     * @var string
     */
    public $certificateName;

    /**
     * @description 证书授予时间
     *
     * @var string
     */
    public $grantTime;
    protected $_name = [
        'certificateName' => 'certificateName',
        'grantTime'       => 'grantTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->certificateName) {
            $res['certificateName'] = $this->certificateName;
        }
        if (null !== $this->grantTime) {
            $res['grantTime'] = $this->grantTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return certificates
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['certificateName'])) {
            $model->certificateName = $map['certificateName'];
        }
        if (isset($map['grantTime'])) {
            $model->grantTime = $map['grantTime'];
        }

        return $model;
    }
}
