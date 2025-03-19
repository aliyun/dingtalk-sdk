<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO;

use AlibabaCloud\Tea\Model;

class certificates extends Model
{
    /**
     * @var string
     */
    public $certificateId;

    /**
     * @var string
     */
    public $certificateName;

    /**
     * @var string
     */
    public $crantTime;
    protected $_name = [
        'certificateId' => 'certificateId',
        'certificateName' => 'certificateName',
        'crantTime' => 'crantTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->certificateId) {
            $res['certificateId'] = $this->certificateId;
        }
        if (null !== $this->certificateName) {
            $res['certificateName'] = $this->certificateName;
        }
        if (null !== $this->crantTime) {
            $res['crantTime'] = $this->crantTime;
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
        if (isset($map['certificateId'])) {
            $model->certificateId = $map['certificateId'];
        }
        if (isset($map['certificateName'])) {
            $model->certificateName = $map['certificateName'];
        }
        if (isset($map['crantTime'])) {
            $model->crantTime = $map['crantTime'];
        }

        return $model;
    }
}
