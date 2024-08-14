<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest;

use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\baseInfo;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\certificates;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\jobExpects;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\personalHonors;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\projectExperiences;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\tags;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO\workExperiences;
use AlibabaCloud\Tea\Model;

class resumeDataVO extends Model
{
    /**
     * @var baseInfo
     */
    public $baseInfo;

    /**
     * @var certificates[]
     */
    public $certificates;

    /**
     * @var jobExpects[]
     */
    public $jobExpects;

    /**
     * @var personalHonors[]
     */
    public $personalHonors;

    /**
     * @var projectExperiences[]
     */
    public $projectExperiences;

    /**
     * @var tags[]
     */
    public $tags;

    /**
     * @var workExperiences[]
     */
    public $workExperiences;
    protected $_name = [
        'baseInfo'           => 'baseInfo',
        'certificates'       => 'certificates',
        'jobExpects'         => 'jobExpects',
        'personalHonors'     => 'personalHonors',
        'projectExperiences' => 'projectExperiences',
        'tags'               => 'tags',
        'workExperiences'    => 'workExperiences',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->baseInfo) {
            $res['baseInfo'] = null !== $this->baseInfo ? $this->baseInfo->toMap() : null;
        }
        if (null !== $this->certificates) {
            $res['certificates'] = [];
            if (null !== $this->certificates && \is_array($this->certificates)) {
                $n = 0;
                foreach ($this->certificates as $item) {
                    $res['certificates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->jobExpects) {
            $res['jobExpects'] = [];
            if (null !== $this->jobExpects && \is_array($this->jobExpects)) {
                $n = 0;
                foreach ($this->jobExpects as $item) {
                    $res['jobExpects'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->personalHonors) {
            $res['personalHonors'] = [];
            if (null !== $this->personalHonors && \is_array($this->personalHonors)) {
                $n = 0;
                foreach ($this->personalHonors as $item) {
                    $res['personalHonors'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->projectExperiences) {
            $res['projectExperiences'] = [];
            if (null !== $this->projectExperiences && \is_array($this->projectExperiences)) {
                $n = 0;
                foreach ($this->projectExperiences as $item) {
                    $res['projectExperiences'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->tags) {
            $res['tags'] = [];
            if (null !== $this->tags && \is_array($this->tags)) {
                $n = 0;
                foreach ($this->tags as $item) {
                    $res['tags'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->workExperiences) {
            $res['workExperiences'] = [];
            if (null !== $this->workExperiences && \is_array($this->workExperiences)) {
                $n = 0;
                foreach ($this->workExperiences as $item) {
                    $res['workExperiences'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resumeDataVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['baseInfo'])) {
            $model->baseInfo = baseInfo::fromMap($map['baseInfo']);
        }
        if (isset($map['certificates'])) {
            if (!empty($map['certificates'])) {
                $model->certificates = [];
                $n                   = 0;
                foreach ($map['certificates'] as $item) {
                    $model->certificates[$n++] = null !== $item ? certificates::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['jobExpects'])) {
            if (!empty($map['jobExpects'])) {
                $model->jobExpects = [];
                $n                 = 0;
                foreach ($map['jobExpects'] as $item) {
                    $model->jobExpects[$n++] = null !== $item ? jobExpects::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['personalHonors'])) {
            if (!empty($map['personalHonors'])) {
                $model->personalHonors = [];
                $n                     = 0;
                foreach ($map['personalHonors'] as $item) {
                    $model->personalHonors[$n++] = null !== $item ? personalHonors::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['projectExperiences'])) {
            if (!empty($map['projectExperiences'])) {
                $model->projectExperiences = [];
                $n                         = 0;
                foreach ($map['projectExperiences'] as $item) {
                    $model->projectExperiences[$n++] = null !== $item ? projectExperiences::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['tags'])) {
            if (!empty($map['tags'])) {
                $model->tags = [];
                $n           = 0;
                foreach ($map['tags'] as $item) {
                    $model->tags[$n++] = null !== $item ? tags::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workExperiences'])) {
            if (!empty($map['workExperiences'])) {
                $model->workExperiences = [];
                $n                      = 0;
                foreach ($map['workExperiences'] as $item) {
                    $model->workExperiences[$n++] = null !== $item ? workExperiences::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
